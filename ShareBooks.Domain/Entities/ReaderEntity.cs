﻿using ShareBooks.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShareBooks.Domain.Entities
{
    [Table( "Reader" )]
    public sealed class ReaderEntity : Entity
    {
        public string Name { get; set; }
        public string IdentityDocument { get; set; }
        public string Email { get; set; }
    }
}
