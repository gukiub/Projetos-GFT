package com.gft.cobranca;

import java.util.Locale;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.web.servlet.LocaleResolver;
import org.springframework.web.servlet.i18n.FixedLocaleResolver;



@SpringBootApplication
public class CobrancaApplication {

	public static void main(String[] args) {
		SpringApplication.run(CobrancaApplication.class, args);
	}

	@Bean
	public LocaleResolver localResolver() {
		return new FixedLocaleResolver(new Locale("pt", "BR"));
	}
	
}
