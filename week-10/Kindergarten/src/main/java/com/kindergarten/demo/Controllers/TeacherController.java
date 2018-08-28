package com.kindergarten.demo.Controllers;

import com.kindergarten.demo.Services.TeacherService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class TeacherController {

  private TeacherService teacherService;

  @Autowired
  public TeacherController(TeacherService teacherService) {
    this.teacherService = teacherService;
  }

  @GetMapping("teachers")
  public String getTeachers(Model model) {
    model.addAttribute("teachers", teacherService.getAllTeacher());
    return "/teacher";
  }
}
