using System;

namespace CodeBlogFitess.BL.Model
{
    public class Gender
    {
        /// <summary>
        /// Пол.
        /// </summary>
        public string Name { get;  }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола</param>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя поля не может быть пустым или null", nameof(name));
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}