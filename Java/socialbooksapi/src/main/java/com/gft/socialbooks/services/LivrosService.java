package com.gft.socialbooks.services;

import java.util.Date;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.stereotype.Service;

import com.gft.socialbooks.domain.Comentario;
import com.gft.socialbooks.domain.Livro;
import com.gft.socialbooks.repository.ComentariosRepository;
import com.gft.socialbooks.repository.LivrosRepository;
import com.gft.socialbooks.services.exceptions.LivroNaoEncontradoException;




@Service
public class LivrosService {
	
	@Autowired
	private LivrosRepository livrosRepository;
	
	@Autowired
	private ComentariosRepository comentariosRepository;
	
	public List<Livro> listar() {
		return livrosRepository.findAll();
	}
	
	public Optional<Livro> buscar(Long id) {
		Optional<Livro> livro = livrosRepository.findById(id);
		
		if(!livro.isPresent()) {
			throw new LivroNaoEncontradoException("O livro não pode ser encontrado");
		}
		
		return livro;
	}
	
	
	public Livro salvar(Livro livro) {
		livro.setId(null);
		return livrosRepository.save(livro);
	}
	
	public void deletar(Long id) {
		try {
			livrosRepository.deleteById(id);
		} catch (EmptyResultDataAccessException e) {
			throw new LivroNaoEncontradoException("O livro não pode ser encontrado");
		}
	}
	
	
	public void atualizar(Livro livro) {
		verificarExistencia(livro);
		livrosRepository.save(livro);
	}
	
	private void verificarExistencia(Livro livro) {
		buscar(livro.getId());
	}
	
	public Comentario salvarComentario(Long livroId, Comentario comentario){
		Livro livro = buscar(livroId).get();
		
		comentario.setLivro(livro);
		comentario.setData(new Date());
		return comentariosRepository.save(comentario);
	} 
		  
	public List<Comentario> listarComentarios(Long livroId){
		Livro livro = buscar(livroId).get();
		
		return livro.getComentarios();
	}
}
