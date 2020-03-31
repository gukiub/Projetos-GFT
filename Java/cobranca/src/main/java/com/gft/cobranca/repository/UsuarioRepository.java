package com.gft.cobranca.repository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.gft.cobranca.model.Usuario;

@Repository
public interface UsuarioRepository extends CrudRepository<Usuario, String> {

	Usuario findByLogin(String login);
	
}
