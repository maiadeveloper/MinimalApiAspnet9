using IperonprevAPI.Services;

namespace IperonprevAPI.EndPoints
{
    public static class SistemaEndPoint
    {
        public static void MapSistema(this WebApplication app)
        {
            app.MapGet("/sistemas/{id}", async (SistemaService service, int id) =>
            {
                var sistema = await service.GetById(id);

                return sistema != null ? Results.Ok(sistema) : Results.NotFound();
            });

            app.MapGet("/sistemas", async (SistemaService service) =>
            {
                var sistemas = await service.GetAll();

                return Results.Ok(sistemas);
            });
        }
    }
}
