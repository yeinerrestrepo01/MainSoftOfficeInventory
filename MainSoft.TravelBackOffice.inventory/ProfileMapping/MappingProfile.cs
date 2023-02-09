using AutoMapper;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;

namespace MainSoft.TravelBackOffice.InventoryApi.ProfileMapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            this.CreateMap<LibrosRequest, Libros>();
            this.CreateMap<AutoresRequest, Autores>();
            this.CreateMap<RequestEditoriales, Editoriales>();
        }
    }
}
