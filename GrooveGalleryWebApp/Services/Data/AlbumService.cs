using GrooveGalleryWebApp.Data;
using GrooveGalleryWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrooveGalleryWebApp.Services.Data;

    public class AlbumService : IAlbumService
    {
        private GrooveGalleryDbContext _context;

        public AlbumService(GrooveGalleryDbContext context)
        {
            _context = context;
        }

        public void Alterar(Album album)
        {



                var albumEncontrado = Obter(album.AlbumId);
                albumEncontrado.Nome = album.Nome;
                albumEncontrado.Artista = album.Artista;
                albumEncontrado.Descricao = album.Descricao;
                albumEncontrado.ImagemUri = album.ImagemUri;
                albumEncontrado.Preco = album.Preco;
                albumEncontrado.EntregaExpressa = album.EntregaExpressa;
                albumEncontrado.Duracao = album.Duracao;
                albumEncontrado.DataLancamento = album.DataLancamento;
                albumEncontrado.DataCadastro = album.DataCadastro;
                albumEncontrado.MarcaId = album.MarcaId;

                _context.SaveChanges();
            
           
        }

        public void Excluir(int id)
        {
                var albumEncontrado = Obter(id);

            
                _context.Album.Remove(albumEncontrado);
                _context.SaveChanges();
            
        }

        public void Incluir(Album album)
        {
            _context.Album.Add(album);
            _context.SaveChanges();
        }

        public Album Obter(int id)
        {
            return _context.Album.SingleOrDefault(item => item.AlbumId == id);
        }
        
        public IList<Marca> ObterTodasAsMarcas()
        {
            return _context.Marca.ToList();
        }
                
        public IList<Album> ObterTodos()
        {
            return _context.Album.ToList();
        }
    }

