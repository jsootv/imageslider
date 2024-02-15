using System.ComponentModel.DataAnnotations;

namespace DotNet.Library.DTOs;

/// <summary>
/// 회원가입 DTO
/// </summary>
public class RegisterDTO
{
    /// <summary>
    /// 회원 아이디
    /// </summary>
    [Key, Required(ErrorMessage = "회원 아이디를 입력하세요.")]
    [MinLength(length: 6, ErrorMessage = "회원 아이디는 6자 이상 입력하세요.")]
    [Display(Name = "회원 아이디")]
    public string MemberId { get; set; } = default!;

    /// <summary>
    /// 회원 성
    /// </summary>
    [Required(ErrorMessage = "회원 성을 입력하세요.")]
    [Display(Name = "회원 성")]
    public string LastName { get; set; } = default!;

    /// <summary>
    /// 회원 이름
    /// </summary>
    [Required(ErrorMessage = "회원 이름을 입력하세요.")]
    [Display(Name = "회원 이름")]
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// 회원 이메일
    /// </summary>
    [EmailAddress(ErrorMessage = "회원 이메일을 올바르게 입력하세요.")]
    [RegularExpression(pattern: @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?",
                       ErrorMessage = "회원 이메일을 형식에 맞게 올바르게 입력하세요.")]
    [Required(ErrorMessage = "회원 이메일을 입력하세요.")]
    [Display(Name = "회원 이메일")]
    public string MemberEmail { get; set; } = default!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [DataType(DataType.Password, ErrorMessage = "비밀번호를 올바르게 입력하세요.")]
    [Required(ErrorMessage = "비밀번호를 입력하세요.")]
    [MinLength(length: 8, ErrorMessage = "비밀번호는 8자 이상 입력하세요.")]
    [Display(Name = "비밀번호")]
    public string Password { get; set; } = default!;

    /// <summary>
    /// 비밀번호 확인
    /// </summary>
    [DataType(DataType.Password, ErrorMessage = "비밀번호를 올바르게 확인입력하세요.")]
    [Required(ErrorMessage = "비밀번호를 확인입력하세요.")]
    [Compare(nameof(Password), ErrorMessage = "비밀번호가 일치하지 않습니다. 다시 입력하세요.")]
    [Display(Name = "비밀번호 확인")]
    public string ConfirmPassword { get; set; } = default!;
}
