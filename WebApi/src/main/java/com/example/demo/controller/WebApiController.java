package com.example.demo.controller;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api")
public class WebApiController {
 
  @RequestMapping("hello")
  private String hello() {
      return "SpringBoot!";
  }

  /** POST処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.POST)
  private String create(@RequestParam String param, @PathVariable String id, @RequestBody String data) {
      return "Called POST.\r\n[id]=" + id + "\r\n[data]=" + data + "\r\n[param]=" + param;
  }

  /** GET処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.GET)
  private String read(@RequestParam String param, @PathVariable String id) {
      return "Called GET.\r\n[id]=" + id + "\r\n[param]=" + param;
  }
  /** DELETE処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.DELETE)
  private String delete(@RequestParam String param, @PathVariable String id) {
      return "Called DELETE.\r\n[id]=" + id + "\r\n[param]=" + param;
  }

  /** PUT処理 */
  @RequestMapping(value="/resource/{id}", method=RequestMethod.PUT)
  private String update(@RequestParam String param, @PathVariable String id, @RequestBody String data) {
      return "Called PUT.\r\n[id]=" + id + "\r\n[param]=" + param;
  }
}

