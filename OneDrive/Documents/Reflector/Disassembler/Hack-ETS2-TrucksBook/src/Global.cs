System.NotImplementedException: Expression analyzing is not implemented for break(DebugBreakInstruction).
   at Reflector.Disassembler.TranslatorBase.InstructionBase.AnalyzeExpression(NewTranslator translator, Object value)
   at Reflector.Disassembler.TranslatorBase.NodeAnalyzer.Analyze(CodeNode node)
   at Reflector.Disassembler.TranslatorBase.NodeAnalyzer.AnalyzeAll()
   at Reflector.Disassembler.TranslatorBase.NodeAnalyzer.AnalyzeAll(NewTranslator translator)
   at Reflector.Disassembler.NewTranslator.TranslateMethodDeclaration(IMethodDeclaration mD, IMethodBody mB)
   at Reflector.Disassembler.Disassembler.TransformMethodDeclaration(IMethodDeclaration value)
   at Reflector.CodeModel.Visitor.Transformer.TransformMethodDeclarationCollection(IMethodDeclarationCollection methods)
   at Reflector.Disassembler.Disassembler.TransformTypeDeclaration(ITypeDeclaration value)
   at Reflector.Application.Translator.TranslateTypeDeclaration(ITypeDeclaration value, Boolean memberDeclarationList, Boolean methodDeclarationBody)
   at Reflector.Application.ExportSource.CodeFile.WriteToOutput(ILanguageWriterConfiguration configuration, ILanguage language, ITranslator disassembler)

