using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public Gallery(string name)
        {
            Name = name;
            Author = new User();
            Midias = new List<Midia>();
        }

        public string Name { get; set; }
        public List<Midia> Midias { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Name))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if(AuthorId == Guid.Empty)
                throw new ArgumentNullException("'AuthorId' não foi preenchido");

        }
    }
}
