using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNet.ApiService.Data.DomainModel;

/// <summary>
/// 회원
/// </summary>
public class Member
{
    /// <summary>
    /// 회원아이디
    /// </summary>
    [Key, StringLength(50), Column(TypeName = "varchar(50)")]
    public string MemberId { get; set; } = default!;

    /// <summary>
    /// 회원 이름
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// 회원 성
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = default!;

    /// <summary>
    /// 회원 이메일
    /// </summary>
    [Required, StringLength(320), Column(TypeName = "varchar(320)")]
    public string MemberEmail { get; set; } = default!;

    #region Password 관련
    /// <summary>
    /// GUID 솔트
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "nvarchar(50)")]
    public string GUIDSalt { get; set; } = default!;

    /// <summary>
    /// RNG 솔트
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "nvarchar(50)")]
    public string RNGSalt { get; set; } = default!;

    /// <summary>
    /// 비밀번호 해시(SHA로 암호화된 데이터)
    /// </summary>
    [Required, StringLength(130), Column(TypeName = "nvarchar(130)")]
    public string PasswordHash { get; set; } = default!;
    #endregion

    /// <summary>
    /// 접속실패횟수
    /// </summary>
    [Required]
    public int AccessFailedCount { get; set; } = 0;

    /// <summary>
    /// 멤버십 탈퇴여부(true:탈퇴대기,false:멤버십상태)
    /// </summary>
    [Required]
    public bool IsMembershipWithdrawn { get; set; } = false;

    /// <summary>
    /// 마지막 활동아이디
    /// </summary>
    [Required, StringLength(50), Column(TypeName = "varchar(50)")]
    public string LastActivityId { get; set; } = default!;

    /// <summary>
    /// 회원가입일시
    /// </summary>
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime JoinedDate { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// 회원별 보유권한 리스트
    /// </summary>
    public ICollection<MemberRolesByMember> MemberRolesByMembers { get; set; } = default!;
}
