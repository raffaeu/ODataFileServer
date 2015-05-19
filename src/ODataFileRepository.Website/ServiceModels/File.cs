﻿using ODataFileRepository.Website.DomainModels.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataFileRepository.Website.ServiceModels
{
    public class File : IFileMetadata
    {
        public File()
        {
        }

        public File(IFileMetadata fileMetadata)
        {
            FullName = fileMetadata.FullName;
            MediaType = fileMetadata.MediaType;
        }

        [Key]
        public string FullName { get; set; }

        [NotMapped]
        public string MediaType { get; set; }
    }
}