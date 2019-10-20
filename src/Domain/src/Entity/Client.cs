using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Domain.src.Entity
{
    public class Client
    {
        public Client()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Document { get; set; }

    }
}