package com.gft.cobranca.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Service;

import com.gft.cobranca.model.Usuario;
import com.gft.cobranca.repository.UsuarioRepository;

@Service
public class CadastroUsuarioService {

	@Autowired
	private UsuarioRepository usuarios;

	public void salvar(Usuario usuario) {
		usuarios.save(usuario);
	}


}
