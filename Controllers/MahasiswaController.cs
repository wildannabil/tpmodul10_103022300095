using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul10_103022300095;

namespace tpmodul10_103022300095.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Wildan Nabil Ramdhany", Nim = "103022300095" },
            new Mahasiswa { Nama = "Maulana Jidan Azizi", Nim = "103022300083" },
            new Mahasiswa { Nama = "Ahmad Naufal Al Ghiffari", Nim = "103022300006" }
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return daftarMahasiswa;
        }

        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
