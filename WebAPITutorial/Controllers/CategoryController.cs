using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SQLitePCL;
using WebAPITutorial.Data;
using WebAPITutorial.Models;
using WebAPITutorial.Models.DTO;
using WebAPITutorial.Repositories;

namespace WebAPITutorial.Controllers;

public class CategoryController : BaseControllerAPI
{   
    //using repository pattern
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult GetAllCategories()
    {
        List<Category> categories = _categoryRepository.GetAll().ToList();
        List<CategoryDTO> categoriesRespond = _mapper.Map<List<CategoryDTO>>(categories);
        return Ok(categoriesRespond);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        // var category = _context.Categories.Include(
        //     c => c.Products).FirstOrDefault(
        //     c => c.CategoryId == id);
        var category = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

        if(category is null)
        {
            return NotFound();
        }

        var categoryDTO = _mapper.Map<CategoryDTO>(category);
        return Ok(categoryDTO);
    }

    [HttpPost]
    public IActionResult AddCategory(CategoryDTO? categoryRequest)
    {
        if(categoryRequest is null)
        {
            return NotFound();
        }

        Category category = _mapper.Map<Category>(categoryRequest);
        _categoryRepository.Add(category);
        _categoryRepository.Save();
        return Ok(category);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, Category? updatedCategory)
    {
        var categoryToUpdate = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

        if(categoryToUpdate is null)
        {
            return NotFound($"Category id {id} not found");
        }

        if(updatedCategory is null)
        {
            return NotFound("Updated category not found");
        }

        if(updatedCategory.CategoryName is not null)
        {
            categoryToUpdate.CategoryName = updatedCategory.CategoryName;
        }

        if(updatedCategory.Description is not null)
        {
            categoryToUpdate.Description = updatedCategory.Description;
        }
        _categoryRepository.Save();

        return Ok(categoryToUpdate);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _categoryRepository.Get(
            c => c.CategoryId == id).FirstOrDefault();

        if(category is null)
        {
            return NotFound();
        }

        _categoryRepository.Remove(category);
        _categoryRepository.Save();
        return Ok(category);
    }
}
