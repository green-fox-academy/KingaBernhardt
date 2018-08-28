package com.kindergarten.demo.Controllers;

import com.kindergarten.demo.Services.ParentService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;

@Controller
public class ParentController {

  private ParentService parentService;

  @Autowired
  public ParentController(ParentService parentService) {
    this.parentService = parentService;
  }
}
