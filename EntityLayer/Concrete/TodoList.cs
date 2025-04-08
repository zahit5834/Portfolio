﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        public string? Content { get; set; }
        public bool? Status { get; set; }
    }
}
