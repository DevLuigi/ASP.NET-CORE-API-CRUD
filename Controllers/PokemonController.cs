namespace AspNetCoreCrud.Controllers
{
    using AspNetCoreCrud.Domains;
    using AspNetCoreCrud.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PokemonController(AppDbContext context)
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> listAllPokemons() 
        {
            var pokemons = await _context.Pokemons.ToListAsync();
            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getPokemonById(int id) 
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            
            if (pokemon == null) 
            {
                return NotFound();
            }

            return Ok(pokemon);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePokemon([FromBody] Pokemon pokemon) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(getPokemonById), new { id = pokemon.Id }, pokemon);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updatePokemon(int id, [FromBody] Pokemon pokemon)
        {
            if (id != pokemon.Id)
            {
                return BadRequest("ID do produto não coincide");
            }

            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            var pokemonExist = await _context.Pokemons.FindAsync(id);
            if (pokemonExist == null)
            {
                return NotFound();
            }

            pokemonExist.Name = pokemon.Name;
            pokemonExist.Description = pokemon.Description;
            pokemonExist.Level = pokemon.Level;

            _context.Pokemons.Update(pokemonExist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null) 
            {
                return NotFound();
            }

            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();

            return NoContent();
    }
}