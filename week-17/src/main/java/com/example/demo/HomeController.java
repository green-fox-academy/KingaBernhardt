package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {
  
  private HomeService homeService;
  
  @Autowired
  public HomeController(HomeService homeService){
    this.homeService = homeService;
  }
  @PostMapping("/")
  public String index(@RequestBody String name){
    return homeService.nameCheck(name);
  }
  
}
