using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController(ClientRepository clientRepository) : ControllerBase
    {
        private readonly ClientRepository _clientRepository = clientRepository;
    }
}