using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static BlackKiteTask.Models.Enums;

namespace BlackKiteTask.Models
{
    class Status
    {
        [Required]
        public bool IsValid { get; set; }
        public string ClientId { get; set; }
        public bool CanStartScan { get; set; }
        public string CurrentIp { get; set; }
        public DateTime? ExpirationDateOfClientCredential { get; set; }
        public string ExpirationDateOfToken { get; set; }

        [EnumDataType(typeof(RoleEnum))]
        public string Role { get; set; }

    }

   }
