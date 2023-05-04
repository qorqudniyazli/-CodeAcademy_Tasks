using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enum_Task.Models
{
    public enum ShippingStatus
    {
        None = 0,

        [Display(Name = "Aktif Kullanıcıları Listeler")]
        Active = 1,


        [Display(Name = "Pasif Kullanıcıları Listeler")]
        Passive,


        [Display(Name = "Silinmiş Kullanıcıları Listeler")]
        Deleted,


        [Display(Name = "Kaydını Dondurmuş Kullanıcıları Listeler")]
        Holiday
    }

    enum SingleHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };


    [Flags]
    enum MultiHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };
}
