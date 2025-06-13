using System.ComponentModel.DataAnnotations;

namespace Webform_DK_QL.Models;


public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Họ tên là bắt buộc")]
    [StringLength(100)]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email là bắt buộc")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
    [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    public string PhoneNumber { get; set; }
}

