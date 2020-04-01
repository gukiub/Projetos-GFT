package com.gft.cobranca.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.gft.cobranca.model.Usuario;

@Repository
public interface UsuarioRepository extends JpaRepository<Usuario, String> {

	Usuario findByLogin(String login);
	
}
