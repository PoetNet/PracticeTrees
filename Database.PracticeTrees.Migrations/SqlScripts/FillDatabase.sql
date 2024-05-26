TRUNCATE TABLE "Assets", "Chapters", "Documents" CASCADE;

INSERT INTO "Documents" ("Id", "CreatedAt", "DeletedAt", "Title", "Description")
VALUES
    ('e6a71c76-a17e-4f33-9b03-fadfb8276ef3', NOW(), NULL, 'Document1', 'Description1');

INSERT INTO "Chapters" ("Id", "Title", "Body", "Css", "Order", "CreatedAt", "DeletedAt", "ParentId", "DocumentId")
VALUES
    ('2ee1c76a-3f13-4f03-9ad4-227178174642', 'ChapterTitle1', 'ChapterBody1', 'chapter-css1', 1, NOW(), NULL, NULL, 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174610', 'Sub-ChapterTitle1.1', 'ChapterBody1.1', 'chapter-css1', 3, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174642', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174611', 'Sub-ChapterTitle1.2', 'ChapterBody1.2', 'chapter-css1', 4, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174642', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174620', 'Sub-ChapterTitle1.1.1', 'ChapterBody1.1.1', 'chapter-css1', 3, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174611', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174621', 'Sub-ChapterTitle1.1.2', 'ChapterBody1.1.2', 'chapter-css1', 4, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174611', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174460', 'Sub-ChapterTitle1.1.1.1', 'ChapterBody1.1.1.1', 'chapter-css1', 3, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174620', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174646', 'Sub-ChapterTitle1.1.1.2', 'ChapterBody1.1.1.2', 'chapter-css1', 4, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174620', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174612', 'Sub-ChapterTitle1.3', 'ChapterBody1.3', 'chapter-css1', 5, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174642', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174643', 'ChapterTitle2', 'ChapterBody1', 'chapter-css1', 2, NOW(), NULL, NULL, 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174614', 'Sub-ChapterTitle2.1', 'ChapterBody2.1', 'chapter-css1', 6, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174643', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174615', 'Sub-ChapterTitle2.2', 'ChapterBody2.2', 'chapter-css1', 7, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174643', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174616', 'Sub-ChapterTitle2.3', 'ChapterBody2.3', 'chapter-css1', 8, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174643', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174617', 'Sub-ChapterTitle2.3.1', 'ChapterBody2.3.1', 'chapter-css1', 8, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174616', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3'),
    ('2ee1c76a-3f13-4f03-9ad4-227178174618', 'Sub-ChapterTitle2.3.2', 'ChapterBody2.3.2', 'chapter-css1', 8, NOW(), NULL, '2ee1c76a-3f13-4f03-9ad4-227178174616', 'e6a71c76-a17e-4f33-9b03-fadfb8276ef3');
 
INSERT INTO "Assets" ("Id", "ChapterId", "CreatedAt", "DeletedAt", "Name", "FilePath", "Type")
VALUES
    ('1ee1c76a-3f13-4f03-9ad4-227178174641', '2ee1c76a-3f13-4f03-9ad4-227178174642', NOW(), NULL, 'AssetName1', '/path/to/file1', 1);
