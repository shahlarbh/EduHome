$(document).ready(function () {
    var skipTeacher = 4;

    $(document).on('click', '#loadTeacher', function () {
        var teacherCount = $('#teacherCount').val()
        $.ajax({
            url: "/teacher/loadteachers?skip="+skipTeacher,
            type: "GET",

            success: function (response) {
                $('#teacherRow').append(response)
                skipTeacher += 4;

                if (skipTeacher >= teacherCount)
                $('#loadTeacher').remove()
            },

            error: function (xhr) {

            }
        });
    })


    var skipCourse = 3;

    $(document).on('click', '#loadCourse', function () {
        var courseCount = $('#courseCount').val()
        $.ajax({
            url: "/course/loadcourses?skip=" + skipCourse,
            type: "GET",

            success: function (response) {
                $('#courseRow').append(response)
                skipCourse += 3;

                if (skipCourse >= courseCount)
                    $('#loadCourse').remove()
            },

            error: function (xhr) {

            }
        });
    })


    var skipBlog = 3;

    $(document).on('click', '#loadBlog', function () {
        var blogCount = $('#blogCount').val()
        $.ajax({
            url: "/blog/loadblogs?skip=" + skipBlog,
            type: "GET",

            success: function (response) {
                $('#blogRow').append(response)
                skipBlog += 3;

                if (skipBlog >= blogCount)
                    $('#loadBlog').remove()
            },

            error: function (xhr) {

            }
        });
    })


    var skipEvent = 3;

    $(document).on('click', '#loadEvent', function () {
        var eventCount = $('#eventCount').val()
        $.ajax({
            url: "/event/loadevents?skip=" + skipEvent,
            type: "GET",

            success: function (response) {
                $('#eventRow').append(response)
                skipEvent += 3;

                if (skipEvent >= eventCount)
                    $('#loadEvent').remove()
            },

            error: function (xhr) {

            }
        });
    })


    $(document).on('keyup', '#searchTeachers', function () {
        var searchedTeacherName = $(this).val()

        $.ajax({
            url: `/teacher/search?searchedTeacherFullname=${searchedTeacherName}`,
            type: "GET",

            success: function (response) {
                $('#searchedTeacher').slice(1)
                $('#searchedTeacher').append(response)
            },

            error: function (xhr) {

            }
        });
    })
})
