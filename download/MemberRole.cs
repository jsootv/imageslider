using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNet.ApiService.Data.DomainModel;
/// <summary>
/// 회원 권한
/// </summary>
public class MemberRole
{
    /// <summary>
    /// 권한 유형
    /// </summary>
    [StringLength(50), Column(TypeName = "varchar(50)")]
    public string RoleType { get; set; } = default!;

    /// <summary>
    /// 권한 아이디
    /// </summary>
    [Key, StringLength(50), Column(TypeName = "varchar(50)")]
    public string RoleId { get; set; } = default!;

    /// <summary>
    /// 권한명
    /// </summary>
    [Required, StringLength(100), Column(TypeName = "nvarchar(100)")]
    public string RoleName { get; set; } = default!;

    /// <summary>
    /// 권한설명
    /// </summary>
    [Required, StringLength(100), Column(TypeName = "nvarchar(100)")]
    public string RoleDesc { get; set; } = default!;

    /// <summary>
    /// 권한 우선순위
    /// </summary>
    [Required]
    public byte RolePriority { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Required]
    [DataType(DataType.DateTime)]
    public System.DateTime CreatedDate { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Required]
    [DataType(DataType.DateTime)]
    public System.DateTime ModifiedDate { get; set; }

    /// <summary>
    /// 회원보유권한 리스트
    /// </summary>
    public ICollection<MemberRolesByMember> MemberRolesByMembers { get; set; } = default!;
}
