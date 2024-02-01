namespace DotNet.Library.DTOs;

public class ResponseMemberDTO
{
    /// <summary>
    /// 비밀번호 오류 횟수
    /// </summary>
    public int PasswordErrorCount { get; set; } = 0;

    /// <summary>
    /// 이전 수정일시
    /// </summary>
    public DateTime BeforeTheLastModifiedDate { get; set; }

    /// <summary>
    /// 회원 DTO
    /// </summary>
    public MemberDTO? Member { get; set; }

    /// <summary>
    /// 메시지
    /// </summary>
    public string Message { get; set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    public bool Success { get; set; } = false;
}
