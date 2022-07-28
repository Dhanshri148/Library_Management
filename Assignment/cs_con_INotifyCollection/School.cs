using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Collections.Specialized;

namespace cs_con_INotifyCollection
{
    internal class School:
                          System.Collections.IEnumerable,
                          System.ComponentModel.INotifyPropertyChanged,
                          System.Collections.Specialized.INotifyCollectionChanged
    {
        private List<Student> _students;

        #region System.ComponentModel.INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region System.Collections.Specialized.INotifyCollectionChanged members

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

        private string _schoolName;

        public string SchoolName
        {
            get 
            {
                return _schoolName; 
            }

            private set
            {
                if(this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("SchoolName"));
                }
                _schoolName = value;
            }
        }

        public School(string schoolName)
        {
            SchoolName = schoolName;
            _students = null;
        }

        public void Add(Student newStudent)
        {
            if(_students == null)
            {
                _students = new List<Student>();
            }

            _students.Add(newStudent);

            if(this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, newStudent));
            }
        }

        public void Remove(Student existingStudent)
        {
            _students.Remove(existingStudent);

            if(this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, existingStudent));
            }
        }

        public Student this[string nameOfStudentToFind]
        {
            get
            {
                Student studFound = null;

                foreach(Student stud in _students)
                {
                    if(stud.Name == nameOfStudentToFind)
                    {
                        studFound = stud;
                        break;
                    }
                }
                return studFound;
            }
        }

        #region System.Collections.IEnumerable members

        public IEnumerator GetEnumerator()
        {
            if(_students != null)
            {
                foreach(Student student in _students)
                {
                    yield return student;
                }
            }
            else
            {
                yield break;
            }
        }

        #endregion
    }
}
