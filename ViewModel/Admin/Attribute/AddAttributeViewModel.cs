using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DomainClasses.Enums;

namespace ViewModel.Admin
{
    public class AddAttributeViewModel
    {
        [DisplayName("نام")]
        [Required(ErrorMessage = "وارد کردن نام خصوصیات ضروریست")]
        [MaxLength(40, ErrorMessage = "تعداد حروف نام خصوصیت غیر مجاز است")]
        [Remote("AddCheckExistAttributeForCategory", "Category", "Admin", ErrorMessage = "این ویژگی قبلا برای این گروه ثبت شده است", HttpMethod = "POST", AdditionalFields = "CategoryId")]
        public string Name { get; set; }
        [DisplayName("گروه")]
        [Required(ErrorMessage = "انتخاب گروه ضروریست")]
        public long CategoryId { get; set; }
        [DisplayName("افزودن برای فرزندان")]
        public bool CascadeAddForChildren { get; set; }
    }
}
