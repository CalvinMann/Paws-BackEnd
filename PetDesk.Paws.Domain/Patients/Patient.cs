﻿using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Patients
{
    public sealed class Patient
    {
        public Id Id { private set; get; }

        public Name Name { private set; get; }

        public Guid AccountId { private set; get; }

        //This is useful if we decide to implement event sourcing
        public int Version { private set; get; }

        private Patient() { }

        public Patient(Name name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}