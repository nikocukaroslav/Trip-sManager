﻿using System.ComponentModel.DataAnnotations;
using Save__plan_your_trips.Models.Domain;

namespace Save__plan_your_trips.Models.ViewModels;

public class EditAlbumRequest
{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Image>? Images { get; set; }
        public AddImageRequest AddImageRequest { get; set; } = new AddImageRequest();
        public string ImageUrls { get; set; }
    
}