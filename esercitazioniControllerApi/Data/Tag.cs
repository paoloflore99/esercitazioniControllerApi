﻿using MessagePack;

namespace esercitazioniControllerApi.Data
{
    public class Tag
    {
        public int Id { get; set; }
        public string NameTag { get; set; }
        public List<Post> Posts { get; set; }
        public Tag()
        {

        }
    }
}
