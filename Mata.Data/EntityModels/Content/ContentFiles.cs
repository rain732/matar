using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matar.Data.EntityModels.Content
{
    public class ContentFiles
    {
        public int FileId { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'FileName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string FileName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'FileName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'ContentType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ContentType { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ContentType' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Content' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public byte[] Content { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Content' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'FilePath' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string FilePath { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'FilePath' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'CreatedBy' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string CreatedBy { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'CreatedBy' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
