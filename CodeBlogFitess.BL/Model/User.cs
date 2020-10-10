using System;


namespace CodeBlogFitess.BL.Model
{
    #region
    /// <summary>
    /// Пользователь
    /// </summary>
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
        #endregion

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="weight">Рост</param>
        /// <param name="height">Вес</param>        /// 
        public User(string name, Gender gender, DateTime birthDate, double weight, int height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым.", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(name));
            }

            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentNullException("Вес не может быть меньше или равен нулю", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentNullException("Рост не может быть меньше или равен нулю", nameof(height));
            }
            #endregion
        }

    }
}
