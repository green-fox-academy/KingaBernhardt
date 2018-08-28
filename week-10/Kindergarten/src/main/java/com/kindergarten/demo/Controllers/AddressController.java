package com.kindergarten.demo.Controllers;

import com.kindergarten.demo.Services.AddressService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class AddressController {

  private AddressService addressService;

  @Autowired
  public AddressController(AddressService addressService) {
    this.addressService = addressService;
  }

  @GetMapping("/address")
  public String listOfAddresses(Model model) {
    model.addAttribute("addresses", addressService.getAddresses());
    return "address";
  }
}
