using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<category>>> GetCategories()
    {
        return await _context.categories.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<category>> GetCategory(int id)
    {
        var category = await _context.categories.FindAsync(id);

        if (category == null)
        {
            return NotFound();
        }

        return category;
    }

    [HttpPost]
    public async Task<ActionResult<category>> PostCategory(category category)
    {
        _context.categories.Add(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }

    [HttpPut("{id}")]
    public ActionResult<product> UpdateCategory(int id, category category)
    {
        // ดึงข้อมูลสินค้าตาม id
        var existingCategory = _context.categories.FirstOrDefault(p => p.category_id == id);

        // ถ้าไม่พบข้อมูลจะแสดงข้อความ Not Found
        if (existingCategory == null)
        {
            return NotFound();
        }

        // แก้ไขข้อมูลสินค้า
        existingCategory.category_name = category.category_name;
        existingCategory.category_status = category.category_status;

        // บันทึกข้อมูล
        _context.SaveChanges();

        // ส่งข้อมูลกลับไปให้ผู้ใช้
        return Ok(existingCategory);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await _context.categories.FindAsync(id);
        if (category == null)
        {
            return NotFound();
        }

        _context.categories.Remove(category);
        await _context.SaveChangesAsync();

        return Ok(category);
    }




}
