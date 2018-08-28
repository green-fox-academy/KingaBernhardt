package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Teacher;
import org.springframework.stereotype.Service;

@Service
public interface TeacherService {

  Teacher getTeacherById(Long id);

  void addTeacher(Teacher teacher);

  void deleteTeacherById(Long id);

  Iterable<Teacher> getAllTeacher();
}
