using System.ComponentModel.DataAnnotations;

namespace DotNet.Library.DTOs;

/// <summary>
/// 회원 로그인 DTO
/// </summary>
public class MemberLoginDTO
{
    /// <summary>
    /// 회원 아이디
    /// </summary>
    [Key, Required(ErrorMessage = "회원 아이디를 입력하세요.")]
    [MinLength(6, ErrorMessage = "회원 아이디는 6자 이상 입력하세요.")]
    [Display(Name = "회원 아이디")]
    public string MemberId { get; set; } = default!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [DataType(DataType.Password, ErrorMessage = "비밀번호를 올바르게 입력하세요.")]
    [Required(ErrorMessage = "비밀번호를 입력하세요.")]
    [MinLength(8, ErrorMessage = "비밀번호는 8자 이상 입력하세요.")]
    [Display(Name = "비밀번호")]
    public string Password { get; set; } = default!;

    /// <summary>
    /// 내정보 기억
    /// </summary>
    [Display(Name = "내정보 기억")]
    public bool RememberMe { get; set; } = false;
}
