package com.kindergarten.demo.Controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class UserController {
  @GetMapping("/")
  public String index() {
    return "index";
  }
  
  @GetMapping("/groups")
  public String groups(){
    return "groups";
  }
  
  @GetMapping("/contact")
  public String contact(){
    return "contact";
  }
}
