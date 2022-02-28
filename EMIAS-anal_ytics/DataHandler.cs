using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;

namespace EMIAS_anal_ytics
{
    public static class DataHandler
    {
        public static Tree GetAssociativeTreeFromCsv(string filePath)
        {
            var parsedList = GetParsedList(filePath);
            if (!parsedList.Any()) return null;

            var res = new Tree();
            
            foreach (var row in parsedList)
            {
                res.Push(row);
            }
            
            res.Sort();
            return res;
        }

        private static List<Row> GetParsedList(string filePath)
        {
            var sr = new StreamReader(filePath, Encoding.Default);
            string line;
            var parsed = new List<Row>();
            
            while ((line = sr.ReadLine()) != null)
            {
                var split = line.Split(';');
                parsed.Add(new Row(
                    split[8].Substring(1, split[8].Length - 2), 
                    split[3].Substring(1, split[3].Length - 2), 
                    split[6].Substring(1, split[6].Length - 2)
                    ));
            }

            sr.Close();
            if (parsed.Any()) parsed.RemoveAt(0);
            return parsed.ToList();
        }
    }

    public class Row
    {
        public readonly string Date;
        public readonly string Department;
        public readonly string Doctor;

        public Row(string date, string department, string doctor)
        {
            Date = date;
            Department = department;
            Doctor = doctor;
        }
    }
    
    public class Tree
    {
        public Dictionary<DateTime, List<Department>> Dates;
        public int SemdCount;

        public Tree()
        {
            Dates = new Dictionary<DateTime, List<Department>>();
            SemdCount = 0;
        }

        public void Push(Row row)
        {
            if (!Dates.ContainsKey(DateTime.Parse(row.Date)))
            {
                Dates[DateTime.Parse(row.Date)] = new List<Department> {new Department(row.Department)};
            }
            else
            {
                if (!Dates[DateTime.Parse(row.Date)].Any(dep => dep.Name == row.Department))
                {
                    Dates[DateTime.Parse(row.Date)].Add(new Department(row.Department));
                }
            }
            Dates[DateTime.Parse(row.Date)].Find(dep => dep.Name == row.Department).Push(row.Doctor);
            SemdCount++;
        }

        public void Sort()
        {
            Dates = Dates
                .OrderBy(date => date.Key)
                .ToDictionary(date => date.Key, date => date.Value);
        }
    }

    public class Doctor
    {
        public string Name;
        public int SemdCount;

        public Doctor(string name)
        {
            Name = name;
            SemdCount = 1;
        }
    }

    public class Department
    {
        public string Name;
        public List<Doctor> DoctorsList = new List<Doctor>();
        public int SemdCount;

        public Department(string name)
        {
            Name = name;
        }

        public void Push(string doctor)
        {
            var isCurrentDoctorInList = DoctorsList.Any(doc => doc.Name == doctor);
            if (isCurrentDoctorInList)
            {
                DoctorsList.Find(doc => doc.Name == doctor).SemdCount++;
            }
            else
            {
                DoctorsList.Add(new Doctor(doctor));
            }

            SemdCount++;
        }
    }
}