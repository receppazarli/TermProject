﻿using System.ComponentModel.DataAnnotations;
using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class UserAuthorization : IEntity
    {
        //[Key]
        public int Id { get; set; }
        public string UserAuthorizationName { get; set; }
    }
}