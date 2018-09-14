package com.kindergarten.demo.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
@NoArgsConstructor
@Setter
@Getter
public class Teacher {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String name;
  private String className;
  private Integer classSize;

  public Teacher(String name, String className, Integer classSize) {
    this.name = name;
    this.className = className;
    this.classSize = classSize;
  }
}
