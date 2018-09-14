package com.kindergarten.demo.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
@NoArgsConstructor
@Getter
@Setter
public class Parent {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String fatherName;
  private String motherName;
  private String fatherBirthdate;
  private String motherBirthdate;
  
  private List<Child> children = new ArrayList<>();

  public Parent(String fatherName, String motherName, String fatherBirthdate, String motherBirthdate) {
    this.fatherName = fatherName;
    this.motherName = motherName;
    this.fatherBirthdate = fatherBirthdate;
    this.motherBirthdate = motherBirthdate;
  }
}
