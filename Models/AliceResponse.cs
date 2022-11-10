using AliceHook.Models.Abstract;

namespace AliceHook.Models
{
    //ОТВЕТ
    public class AliceResponse : AliceResponseBase<UserState, SessionState>
    {
        public AliceResponse(
            AliceRequest request,
            SessionState sessionState = default,
            UserState userState = default
        ) : base(request, sessionState, userState) { }
    }
}
