﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase.SupplyData
{
    public partial class User
    {
        public int UsersId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }
    }
}
