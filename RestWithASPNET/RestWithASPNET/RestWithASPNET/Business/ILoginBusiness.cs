using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCrendentials(UserVO user);
        TokenVO ValidateCredentials(TokenVO token);
        bool RevokeToken(string username);
    }
}
