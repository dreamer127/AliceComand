using AliceHook.Models;

namespace AliceHook.Engine.Modifiers.Abstract
{
    public abstract class ModifierBase
    {
        public bool Run(AliceRequest request, out AliceResponse response)  // Запуск модификатора. out сработает, если будет ответ.
        {
            if (!Check(request)) // Если не прошли проверку, ответ не даём.
            {
                response = null;
                return false;
            }

            response = CreateResponse(request); // Создаем ответ. 
            return true;
        }

        protected virtual AliceResponse CreateResponse(AliceRequest request)
        {
            Phrase phrase = Respond(request);
            return phrase.Generate(request);
        }

        protected abstract bool Check(AliceRequest request); // проверяем подходит ли ответ
        protected abstract Phrase Respond(AliceRequest request);
    }
}