﻿using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllMissoes
{
	public class GetAllMissoesQuery : IRequest<List<MissoesViewModel>>
	{
	}
}
