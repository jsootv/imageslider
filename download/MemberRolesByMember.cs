using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNet.ApiService.Data.DomainModel;
/// <summary>
/// 회원별 보유권한
/// </summary>
public class MemberRolesByMember
{
    /// <summary>
    /// 회원아이디
    /// </summary>
    [Key, StringLength(50), Column(TypeName = "varchar(50)")]
    public string MemberId { get; set; } = default!;

    /// <summary>
    /// 권한유형(website)
    /// </summary>
    [Key, StringLength(50), Column(TypeName = "varchar(50)")]
    public string RoleType { get; set; } = default!;

    /// <summary>
    /// 권한아이디
    /// </summary>
    [Key, StringLength(50), Column(TypeName = "varchar(50)")]
    public string RoleId { get; set; } = default!;

    /// <summary>
    /// 수여자 아이디
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "varchar(50)")]
    public string GrantorId { get; set; } = default!;

    /// <summary>
    /// 권한소유일시
    /// </summary>
    [Required]
    [DataType(DataType.DateTime)]
    public System.DateTime OwnedDate { get; set; }

    /// <summary>
    /// 회원 마스터
    /// </summary>
    public Member Member { get; set; } = default!;

    /// <summary>
    /// 회원 권한
    /// </summary>
    public MemberRole MemberRole { get; set; } = default!;
}
