using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EMIAS_anal_ytics
{
    public static class DataHandler
    {
        public static Node GetAssociativeTreeFromCsv(string filePath)
        {
            var parsedList = GetParsedList(filePath);
            if (!parsedList.Any()) return null;

            var res = new Node();
            
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
    
    public class Node
    {
        public Node Head;
        public Node Previous;
        public Node Next;
        public Dictionary<string, List<Department>> Dates;
        public int SemdCount;

        public Node()
        {
            Dates = new Dictionary<string, List<Department>>();
            SemdCount = 0;
        }

        public void Push(Row row)
        {
            if (!Dates.ContainsKey(row.Date))
            {
                Dates[row.Date] = new List<Department>();
                Dates[row.Date].Add(new Department(row.Department));
            }
            else
            {
                if (!Dates[row.Date].Any(dep => dep.Name == row.Department))
                {
                    Dates[row.Date].Add(new Department(row.Department));
                }
            }
            Dates[row.Date].Find(dep => dep.Name == row.Department).Push(row.Doctor);
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

    public class Date
    {
        public string DateTime;
        public List<Department> DepartmentsList = new List<Department>();
    }
}