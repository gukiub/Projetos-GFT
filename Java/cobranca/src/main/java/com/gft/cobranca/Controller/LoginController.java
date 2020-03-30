package com.gft.cobranca.Controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class LoginController {
	@RequestMapping
	public String home() {
		return "Inicio";
	}
	
	
	@RequestMapping("/login")
	public String entrar() {
		return "login";
	}
}
