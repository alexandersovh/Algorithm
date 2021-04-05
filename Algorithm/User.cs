namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Dada user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// Join properties to parameters.
        /// </summary>
        /// <param name="login">This login.</param>
        /// <param name="name">This is name.</param>
        /// <param name="isPremium">Check premium.</param>
        public User(string login, string name, bool isPremium)
        {
            this.Login = login;
            this.Name = name;
            this.IsPremium = isPremium;
        }

        /// <summary>
        /// Gets or sets a value the item is login.
        /// </summary>
        /// <value>The login of the customer.</value>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets a value the item is name.
        /// </summary>
        /// <value>The Name of the customer.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether  the item is IsPremium.
        /// </summary>
        /// <value> Does it have IsPremium.</value>
        public bool IsPremium { get; set; }
    }
}
