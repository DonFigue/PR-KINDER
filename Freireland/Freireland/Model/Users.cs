﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Users: BaseModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondlastName { get; set; }
        public int Phone { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string Ci { get; set; }
        public string Role { get; set; }

        /// <summary>
        /// GET
        /// </summary> 
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondlastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="ci"></param>
        /// <param name="role"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Users(byte id, string name,string password, string firstName, string lastName, string secondlastName, int phone,char gender, string email, string ci, string role, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Name = name;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SecondlastName = secondlastName;
            this.Phone = phone;
            this.Gender = gender;
            this.Email = email;
            this.Ci = ci;
            this.Role = role;
           
        }

        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondlastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="ci"></param>
        /// <param name="role"></param>
        ///  /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public Users( string name, string password, string firstName, string lastName, string secondlastName, int phone,char gender, string email, string ci, string role)

        {
            Name = name;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SecondlastName = secondlastName;
            this.Phone = phone;
            this.Gender=gender;
            this.Email = email;
            this.Ci = ci;
            this.Role = role;
            
        }
        public Users()
        {

        }






    }
}
