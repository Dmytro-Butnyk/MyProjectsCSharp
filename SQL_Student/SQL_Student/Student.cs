using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Student
{
    public class Student
    {
        private string _name;
        private string _groupName;
        private Dictionary<string, List<int>> _marks;
        // Constructors
        #region
        /// <summary>
        /// no parameters
        /// </summary>
        public Student()
        {
            _name = "No name";
            _groupName = "NoGroupName";
            _marks = new Dictionary<string, List<int>>
            {
                { "Subject1", new List<int> { 1, 2, 3 } },
                { "Subject2", new List<int> { 3, 2, 1 } }
            };
        }
        /// <summary>
        /// full parameters
        /// </summary>
        public Student(string name, string groupName,
            Dictionary<string, List<int>> marks) 
        {
            IsValidName(name);
            IsValidGroupName(groupName);
            IsValidMarks(marks);

            _name = name;
            _groupName = groupName;
            _marks = marks; 
        }
        #endregion

        // Properties && indexator
        #region
        public string Name
        {
            get { return _name; }
            set 
            {
                IsValidName(value);
                _name = value;
            }
        }
        public string GroupName
        {
            get { return _groupName; }
            set
            {
                IsValidGroupName(value);
                _groupName = value;
            }
        }
        public Dictionary<string, List<int>> Marks
        {
            get { return _marks; }
            set
            {
                IsValidMarks(value);
                _marks = value;
            }
        }
        public List<int> this[string subject]
        {
            get
            {
                if (_marks.ContainsKey(subject))
                    return _marks[subject];
                else
                    throw new KeyNotFoundException($"Subject {subject} is not found.");
            }
            set
            {
                if (_marks.ContainsKey(subject))
                    _marks[subject] = value;
                else
                    _marks.Add(subject, value);
            }
        }
        #endregion

        // Methods
        #region
        public void RemoveSubject(string subject)
        {
            if (_marks.ContainsKey(subject))
                _marks.Remove(subject);
            else
                throw new KeyNotFoundException($"Subject {subject} is not found.");
        }
        public override string ToString()
        {
            StringBuilder student = new();
            student.AppendLine($"Name: {_name};");
            student.AppendLine($"Group name: {_groupName};");
            student.AppendLine($"Marks journal:");
            foreach(var subject in _marks)
            {
                student.AppendLine($"{subject.Key}: {string.Join(", ", subject.Value)}");
            }
            return student.ToString();
        }
        #endregion

        // Validation checkers
        #region
        private void IsValidName(string name)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            if (name.Split(' ').Length != 2) throw new FormatException("Wrong name format");
        }
        private void IsValidGroupName(string groupName)
        {
            ArgumentNullException.ThrowIfNull(groupName, nameof(groupName));
            if (groupName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Length != 1) throw new FormatException("Wrong group name format");
        }
        private void IsValidMarks(Dictionary<string, List<int>> marks)
        {
            ArgumentNullException.ThrowIfNull(marks, nameof(marks));
            foreach(var subject in marks)
            {
                foreach (var mark in subject.Value)
                {
                    if (mark > 10 || mark < 1)
                        throw new FormatException($"Wrong format of mark in subject \"{subject.Key}\"");
                }
            }
        }
        #endregion
    }
}
