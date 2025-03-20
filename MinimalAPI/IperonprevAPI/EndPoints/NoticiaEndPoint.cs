using IperonprevAPI.Services;

namespace IperonprevAPI.EndPoints
{
    public static class NoticiaEndPoint
    {
        public static void MapNoticia(this WebApplication app)
        {
            app.MapGet("/noticias/{id}", async (NoticiaService service, int id) =>
            {
                var noticia = await service.GetById(id);

                return noticia != null ? Results.Ok(noticia) : Results.NotFound();
            });

            app.MapGet("/noticias", async (NoticiaService service) =>
            {
                var noticias = await service.GetAll();

                return Results.Ok(noticias);
            });

            app.MapGet("/noticias/getTopDetaque", async (NoticiaService service) =>
            {
                var noticias = await service.GetTopDetaque();

                return Results.Ok(noticias);
            });
        }
    }
}
