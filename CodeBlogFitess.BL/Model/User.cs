using System;


namespace CodeBlogFitess.BL.Model
{
    class User
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; set; }

        public User(string name, Gender gender, DateTime birthDate, double weight, int height)
        {
            if(string.IsNullOrWhiteSpace(name))
            { 
            }

        }

    }
}
