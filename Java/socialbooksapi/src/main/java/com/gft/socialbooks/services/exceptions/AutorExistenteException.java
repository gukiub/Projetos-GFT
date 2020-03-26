package com.gft.socialbooks.services.exceptions;

public class AutorExistenteException extends RuntimeException {
	
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 2077369538621514926L;

	public AutorExistenteException(String mensagem) {
		super(mensagem);
	}
	
	public AutorExistenteException(String mensagem, Throwable causa) {
		super(mensagem, causa);
	}
}
